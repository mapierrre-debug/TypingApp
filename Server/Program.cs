using TypingApp.Shared;

var builder = WebApplication.CreateBuilder(args);

// CRITICAL: Tells the server to locate and serve the Client project's wwwroot assets
builder.WebHost.UseStaticWebAssets();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

var typingPrompts = new List<TypingPrompt>
{
    new TypingPrompt 
    { 
        Id = 1, 
        Title = "C# Mastery Syntax Paradigm", 
        Category = "Programming", 
        Text = "public async Task<IEnumerable<Data>> GetRecordsAsync(Guid systemId) => await context.Records.Where(r => r.IsActive).ToListAsync();" 
    },
    new TypingPrompt 
    { 
        Id = 2, 
        Title = "The Cosmic Expansion Concept", 
        Category = "Space Science", 
        Text = "The universe expanded at an exponential rate during its initial fraction of a second, an epoch known as cosmic inflation." 
    },
    new TypingPrompt 
    { 
        Id = 3, 
        Title = "The Philosophy of Digital Mind", 
        Category = "Philosophy", 
        Text = "Do artificial consciousness matrices experience genuine existential reflection, or merely emulate patterns of complex human thought?" 
    },
    new TypingPrompt 
    { 
        Id = 4, 
        Title = "Advanced Compiler Optimization", 
        Category = "Engineering", 
        Text = "Intermediate representations undergo aggressive dead code elimination and loop unrolling optimization passes inside LLVM execution pipelines." 
    }
};

app.MapGet("api/prompts", () => Results.Ok(typingPrompts));
app.MapFallbackToFile("index.html");

app.Run();
