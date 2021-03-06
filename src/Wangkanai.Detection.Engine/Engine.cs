﻿// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

namespace Wangkanai.Detection
{
    public class Engine : IEngine
    {
        public string Name { get; set; }
        public string Maker { get; set; }
        public EngineType Type { get; set; }
        public IVersion Version { get; set; }
    }
}