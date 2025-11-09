var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// IZBERI ENO OD TEH DVEH:

// Opcija 1: Samo text
app.MapGet("/", () => "Hello World from Azure!");

// ALI Opcija 2: HTML stran (ODSTRANI zgornjo vrstico)
app.MapGet("/", () => Results.Content(@"
<!DOCTYPE html>
<html>
<head>
    <title>Nepremicnine App</title>
    <style>
        body {
            background-color: #f0f8ff;
            display: flex;
            align-items: center;
            justify-content: center;
            height: 100vh;
            font-family: Arial, sans-serif;
            font-size: 48px;
            color: #2c3e50;
            margin: 0;
        }
        .container {
            text-align: center;
            padding: 40px;
            border-radius: 15px;
            background: white;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
        }
    </style>
</head>
<body>
    <div class="container">
        🏠 Nepremicnine App<br>
        <small style='font-size: 24px; color: #7f8c8d;'>Uspešno deluje na Azure!</small>
    </div>
</body>
</html>
", "text/html"));

app.Run();
