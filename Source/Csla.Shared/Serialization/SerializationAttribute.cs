﻿#if !NETSTANDARD1_6
#if NETFX_CORE
//-----------------------------------------------------------------------
// <copyright file="SerializationAttribute.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>Indicates that an object may be</summary>
//-----------------------------------------------------------------------
using System;

namespace System
{
  /// <summary>
  /// Indicates that an object may be
  /// serialized by the MobileFormatter.
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
  public class SerializableAttribute : Attribute
  {
  }
}
#else
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.SerializableAttribute))]
#endif
#endif