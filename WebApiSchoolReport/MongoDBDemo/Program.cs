using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBDemo
{
    class Program
    {
        // 定义接口
        protected static IMongoDatabase _database;
        // 定义客户端
        protected static IMongoClient _client;

        static void Main(string[] args)
        {
            MongoDBConn();
            // 根据集合名称获取集合
            var collection = _database.GetCollection<BsonDocument>("col");

            //查询集合中的第一条数据
            var document = collection.Find(new BsonDocument()).FirstOrDefault();
            Console.WriteLine(document.ToString());
            Console.WriteLine("----------------------------------------");

            //查询数据集合中的所有数据
            var documents = collection.Find(new BsonDocument()).ToList();
            documents.ForEach(f =>
            {
                Console.WriteLine(f.ToString());
            });
            Console.WriteLine("----------------------------------------");

            //筛选：likes=200)
            var filter = Builders<BsonDocument>.Filter.Eq("likes", 200);
            var documentfilter = collection.Find(filter).First();
            Console.WriteLine(documentfilter);
            Console.WriteLine("----------------------------------------");

            //筛选50 < likes <= 100：
             var filterBuilder = Builders<BsonDocument>.Filter;
             var filter2 = filterBuilder.Gt("likes", 50) & filterBuilder.Lte("likes", 100);
            var documentfilter2 = collection.Find(filter2).FirstOrDefault();
            Console.WriteLine(documentfilter2);
            Console.WriteLine("----------------------------------------");

















            // 查询集合中的文档
            var list = Task.Run(async () => await collection.Find(filter).ToListAsync()).Result;


            // 循环遍历输出
            //list.ForEach(p =>
            //{
            //    Console.WriteLine("编号：" + p["stuId"] + ",姓名：" + p["name"].ToString() + ",年龄:" + p["age"].ToString() + ",课程：" + p["subject"].ToString() + ",成绩：" + p["score"].ToString());
            //});

            Console.ReadKey();
        }

        public static void MongoDBConn()
        {
            // 读取连接字符串
            string strCon = ConfigurationManager.ConnectionStrings["mongodbConn"].ConnectionString;
            var mongoUrl = new MongoUrlBuilder(strCon);
            // 获取数据库名称
            string databaseName = mongoUrl.DatabaseName;
            // 创建并实例化客户端
            _client = new MongoClient(mongoUrl.ToMongoUrl());
            //  根据数据库名称实例化数据库
            _database = _client.GetDatabase(databaseName);
        }
    }
}
