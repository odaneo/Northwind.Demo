🧱 技术架构：
层级	内容
表现层	不开发 UI，仅提供 API（REST/GraphQL）
应用层	CQRS、MediatR、DTO、Validation
领域层	DDD（Entity/Aggregate/ValueObject）
基础设施层	EF Core（Code First + Migrations）、Repository、UnitOfWork
接口层	REST API、Swagger、GraphQL（可选）
横切关注	日志、认证授权、缓存、审计、监控、异常处理等

🧰 技术选型：
分类	技术
编程语言	C# 12
平台	.NET 8
数据访问	Entity Framework Core（+ Raw SQL / Dapper 示例）
架构模式	Clean Architecture / Onion Architecture / DDD
API	ASP.NET Core Web API / Swagger / Minimal API 示例
认证授权	JWT / OAuth2 / Role-Based / Policy-Based
缓存	MemoryCache / Redis（StackExchange.Redis）
日志	Serilog + Seq
消息队列	RabbitMQ / Azure Service Bus（可选）
作业调度	Quartz.NET / Hangfire
配置管理	appsettings / IOptions / User Secrets / Azure KeyVault（可选）
审计	自定义中间件 + ActionFilter
异常处理	Exception Middleware + ProblemDetails
测试	xUnit + Moq + Integration Test with Testcontainers
数据迁移	EF Core Migrations + 数据种子
CI/CD	GitHub Actions / Azure DevOps Pipelines（示例配置）
文档	OpenAPI (Swagger) + GraphQL Playground（如启用）
多语言支持	Globalization/Localization 示例
多租户支持	简单的基于 header 的多租户识别
安全实践	HTTPS、Rate Limiting、Input Sanitization、CORS

📂 模块设计（以 Northwind 数据模型为基础）
客户管理（Customers）

产品管理（Products、Categories、Suppliers）

订单管理（Orders、Order Details、Shippers）

员工管理（Employees + 上下级关系）

报表模块（使用 CQRS + LINQ 分析查询）

日志与审计模块

权限模块（Role/Permission）

🛠 开发任务阶段（建议分阶段实施）：
基础搭建：项目结构、EF Core建模、种子数据导入、API 初始框架、Swagger

业务实现：模块按功能分阶段完成（产品、订单、客户）

增强功能：引入认证、缓存、日志、异常处理等横切关注点

高阶集成：消息队列、定时任务、多租户、分布式缓存

优化与部署：性能分析、CI/CD、容器化（Docker）

✅ 最终目标：
构建一个高度模块化、清晰分层、符合现代 .NET 开发规范的后端系统

可以作为面试展示项目 / 技术沉淀 / 内部培训教材

覆盖主流 .NET 企业级应用开发中用到的关键技术栈

