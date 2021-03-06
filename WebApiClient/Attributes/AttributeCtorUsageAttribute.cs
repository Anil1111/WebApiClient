﻿using System;

namespace WebApiClient.Attributes
{
    /// <summary>
    /// 表示特性的构造函数使用范围
    /// </summary>
    [AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false)]
    public sealed class AttributeCtorUsageAttribute : Attribute
    {
        /// <summary>
        /// 获取使用范围
        /// </summary>
        public AttributeCtorTargets Targets { get; }

        /// <summary>
        /// 特性的构造函数使用范围
        /// </summary>
        /// <param name="targets">使用范围</param>
        public AttributeCtorUsageAttribute(AttributeCtorTargets targets)
        {
            this.Targets = targets;
        }
    }
}
