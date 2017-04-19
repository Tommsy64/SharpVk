// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2017
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineRasterizationStateCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineRasterizationStateCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DepthClampEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 RasterizerDiscardEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public PolygonMode PolygonMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public CullModeFlags CullMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public FrontFace FrontFace; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DepthBiasEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public float DepthBiasConstantFactor; 
        
        /// <summary>
        /// 
        /// </summary>
        public float DepthBiasClamp; 
        
        /// <summary>
        /// 
        /// </summary>
        public float DepthBiasSlopeFactor; 
        
        /// <summary>
        /// 
        /// </summary>
        public float LineWidth; 
    }
}