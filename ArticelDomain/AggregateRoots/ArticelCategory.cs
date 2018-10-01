﻿using System;
using System.Collections.Generic;
using System.Text;
using Zaaby.DDD.Abstractions.Domain;

namespace ArticelDomain.AggregateRoots
{
    /// <summary>
    /// 文章分类
    /// </summary>
    public class ArticelCategory : IAggregateRoot<string>
    {
        public string Id { get; private set; }
        public string Name { get; private set; }

        public ArticelCategory(string id, string name)
        {
            Assert.IsNotNullOrWhiteSpace("文章分类id", id);
            Assert.IsNotNullOrWhiteSpace("文章分类名称", Name);
            this.Id = id;
            this.Name = name;
        }
    }
}
