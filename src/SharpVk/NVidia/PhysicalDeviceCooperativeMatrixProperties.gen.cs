// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2019
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
using System.Runtime.InteropServices;

namespace SharpVk.NVidia
{
    /// <summary>
    /// Structure describing cooperative matrix properties supported by an
    /// implementation
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceCooperativeMatrixProperties
    {
        /// <summary>
        /// A bitfield of VkShaderStageFlagBits describing the shader stages
        /// that cooperative matrix instructions are supported in.
        /// cooperativeMatrixSupportedStages will have the
        /// VK_SHADER_STAGE_COMPUTE_BIT bit set if any of the physical device’s
        /// queues support VK_QUEUE_COMPUTE_BIT.
        /// </summary>
        public SharpVk.ShaderStageFlags CooperativeMatrixSupportedStages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe PhysicalDeviceCooperativeMatrixProperties MarshalFrom(SharpVk.Interop.NVidia.PhysicalDeviceCooperativeMatrixProperties* pointer)
        {
            PhysicalDeviceCooperativeMatrixProperties result = default(PhysicalDeviceCooperativeMatrixProperties);
            result.CooperativeMatrixSupportedStages = pointer->CooperativeMatrixSupportedStages;
            return result;
        }
    }
}
