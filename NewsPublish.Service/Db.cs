/*
*┌────────────────────────────────────────────────┐
*│　描    述：Db                                                    
*│　作    者：mask                                              
*│　版    本：1.0                                              
*│　创建时间：2019/12/23 10:29:09                        
*└────────────────────────────────────────────────┘
*/
using Microsoft.EntityFrameworkCore;
using NewsPublish.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPublish.Service
{
    /// <summary>
    /// 数据库访问上下文
    /// </summary>
    public class Db : DbContext
    {
        public Db() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=NewsPublish;User ID=sa;Password=123", b => b.UseRowNumberForPaging());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Model.Entity.Banner> Banner { get; set; }
        public virtual DbSet<NewsClassify> NewsClassify { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsComment> NewsComment { get; set; }
    }
}
