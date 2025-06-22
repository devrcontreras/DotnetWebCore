var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DotnetWebCore_Identity>("dotnetwebcore-identity");

builder.Build().Run();
