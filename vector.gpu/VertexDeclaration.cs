/* ===============================================================================  
 * Copyright (c) 2013 Vector by sinclair
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 * 
 * =============================================================================== */

using System;
using System.Collections.Generic;
using System.Reflection;

namespace Vector.Gpu
{
    /// <summary>
    /// Sematic binding for Vertex Structures. 
    /// </summary>
    public class VertexAttributeAttribute : Attribute
    {
        private ElementBinding elementBinding;
        private ElementType    elementType;
        private int            typeCount;

        public VertexAttributeAttribute(ElementBinding elementBinding, ElementType elementType, int typeCount)
        {
            this.elementBinding = elementBinding;
            this.elementType    = elementType;
            this.typeCount      = typeCount;
        }
        /// <summary>
        /// The binding sematic
        /// </summary>
        public ElementBinding ElementBinding
        {
            get { return this.elementBinding; }
        }
        /// <summary>
        /// The element Type.
        /// </summary>
        public ElementType ElementType
        {
            get { return this.elementType; }
        }
        /// <summary>
        /// The count of these elements
        /// </summary>
        public int TypeCount
        {
            get { return this.typeCount; }
        }
    }

    /// <summary>
    /// <para>Vertex Element</para>
    /// <para>Describes a Vertex Element within a Sequential Vertex Structure.</para>
    /// </summary>
    public class VertexElement
    {
        private ElementBinding  elementBinding;
        private ElementType     elementType;
        private int             typeCount;
        private int             stride;
        private int             ordinal;

        public VertexElement(ElementBinding elementBinding, ElementType elementType, int typeCount, int stride, int ordinal)
        {
            this.elementBinding = elementBinding;
            this.elementType    = elementType;
            this.typeCount      = typeCount;
            this.stride         = stride;
            this.ordinal        = ordinal;
        }
        /// <summary>
        /// The semantic Binding for this Element.
        /// </summary>
        public ElementBinding ElementBinding
        {
            get { return this.elementBinding; }
            set { this.elementBinding = value; }
        }
        /// <summary>
        /// The Type of the internal elements making up this element.
        /// </summary>
        public ElementType    ElementType
        {
            get { return this.elementType; }
            set { this.elementType = value; }
        }
        /// <summary>
        /// Returns the number of types representing this element.
        /// </summary>
        public int            TypeCount
        {
            get { return this.typeCount; }
            set { this.typeCount = value; }
        }
        /// <summary>
        /// The stride between 2 successive vertices.
        /// </summary>
        public int            Stride
        {
            get { return this.stride; }
            set { this.stride = value; }
        }

        /// <summary>
        /// The Ordinal, as in, the location within a series of bytes in which this element is referencing.
        /// </summary>
        public int            Ordinal
        {
            get { return this.ordinal; }
            set { this.ordinal = value; }
        }
    }

    /// <summary>
    /// <para>Vertex Declaration</para>
    /// <para>Describes a Vertex</para>
    /// </summary>
    public class VertexDeclaration 
    {
        private List<VertexElement> elements;

        public VertexDeclaration()
        {
            this.elements = new List<VertexElement>();
        }

        public VertexDeclaration(VertexElement[] elements)  
        {
            this.elements = new List<VertexElement>();

            this.elements.AddRange(elements);
        }
     
        public List<VertexElement> Elements
        {
            get { return this.elements; }
        }

        /// <summary>
        /// The size of the vertex this declaration is representing.
        /// </summary>
        public int SizeInBytes
        {
            get
            {
                int result = 0;

                if (elements.Count > 0)
                {
                    result = elements[0].Stride;
                }

                return result;
            }
        }

        /// <summary>
        /// Builds a VertexDeclaration based on a Vertex structure type. The Vertex Structure "must" have a StructLayout and also
        /// have VertexAttributes applied to its fields. 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static VertexDeclaration GetDeclarationFromType(Type vertexStructure)
        {
            #region Does this type support the StructLayout Layout Kind Attribute

            string attributes = vertexStructure.Attributes.ToString();

            if (!attributes.Contains("SequentialLayout"))
            {
                throw new Exception(vertexStructure.ToString() + " does not have a [System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential)] attribute.");
            }

            #endregion

            FieldInfo[] fields = vertexStructure.GetFields();

            #region Iterate through to get the stride

            int stride = 0;

            foreach (FieldInfo field in fields)
            {
                VertexAttributeAttribute[] vertexElements = (VertexAttributeAttribute[])field.GetCustomAttributes(typeof(VertexAttributeAttribute), false);
                if (vertexElements.Length > 0)
                {
                    int multiplier = 0;
                    switch (vertexElements[0].ElementType)
                    {
                        case ElementType.Byte: multiplier = 1; break;
                        case ElementType.Double: multiplier = 8; break;
                        case ElementType.Float: multiplier = 4; break;
                        case ElementType.Int: multiplier = 4; break;
                        case ElementType.Short: multiplier = 2; break;
                        case ElementType.UByte: multiplier = 1; break;
                        case ElementType.UInt: multiplier = 4; break;
                        default: multiplier = 0; break;
                    }
                    stride += vertexElements[0].TypeCount * multiplier;
                }
            }

            #endregion

            VertexDeclaration declaration = new VertexDeclaration();

            int ordinal = 0;

            foreach (FieldInfo field in fields)
            {
                VertexAttributeAttribute[] vertexElements = (VertexAttributeAttribute[])field.GetCustomAttributes(typeof(VertexAttributeAttribute), false);

                //bool foundPosition = false;

                if (vertexElements.Length > 0)
                {
                    if (vertexElements[0].ElementBinding == ElementBinding.Vertex)
                    {
                       // foundPosition = true;
                    }

                    declaration.Elements.Add(new VertexElement(vertexElements[0].ElementBinding, vertexElements[0].ElementType, vertexElements[0].TypeCount, stride, ordinal));

                    int multiplier = 0;

                    switch (vertexElements[0].ElementType)
                    {
                        case ElementType.Byte:   multiplier = 1; break;
                        case ElementType.Double: multiplier = 8; break;
                        case ElementType.Float:  multiplier = 4; break;
                        case ElementType.Int:    multiplier = 4; break;
                        case ElementType.Short:  multiplier = 2; break;
                        case ElementType.UByte:  multiplier = 1; break;
                        case ElementType.UInt:   multiplier = 4; break;
                        default: multiplier = 0; break;
                    }

                    ordinal += vertexElements[0].TypeCount * multiplier;
                }
            }

            return declaration;
        }

        /// <summary>
        /// Returns a string representation of this Vertex Declaration.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = "VertexDeclaraion: \n";
            foreach (VertexElement element in this.elements)
            { 
                result += string.Format("  VertexElement:    \n"  + 
                                        "    Binding   : {0} \n" + 
                                        "    Type      : {1} \n" +  
                                        "    TypeCount : {2} \n" +
                                        "    Ordinal   : {3} \n" +
                                        "    Stride    : {4} \n", 
                element.ElementBinding, 
                element.ElementType,
                element.TypeCount,
                element.Ordinal, 
                element.Stride);    
            }
            return result;
        }

    }


}
