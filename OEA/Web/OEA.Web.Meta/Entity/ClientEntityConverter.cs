﻿/*******************************************************
 * 
 * 作者：胡庆访
 * 创建时间：20120315
 * 说明：此文件只包含一个类，具体内容见类型注释。
 * 运行环境：.NET 4.0
 * 版本号：1.0.0
 * 
 * 历史记录：
 * 创建文件 胡庆访 20120315
 * 
*******************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OEA.Web;

namespace OEA
{
    /// <summary>
    /// 客户端实体的序列化器
    /// </summary>
    public static class ClientEntityConverter
    {
        public static Type ToClientType(string clientName)
        {
            //作为服务端，对 Web 及 WPF 的处理应该是一样的，否则 Web 的项目无法直接为 WPFClient 提供服务。

            return ClientEntities.Find(clientName).EntityType;

            //if (OEAEnvironment.IsWeb)
            //{
            //    return ClientEntities.Find(clientName).EntityType;
            //}

            //return Type.GetType(clientName);
        }

        public static string ToClientName(Type clientType)
        {
            return ClientEntities.GetClientName(clientType);

            //if (OEAEnvironment.IsWeb)
            //{
            //    return ClientEntities.GetClientName(clientType);
            //}

            //return clientType.AssemblyQualifiedName;
        }
    }
}