﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore.TestModels.JsonQuery
{
    public class JsonEntityBasicForCollection
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? ParentId { get; set; }
        public JsonEntityBasic Parent { get; set; }
    }
}
