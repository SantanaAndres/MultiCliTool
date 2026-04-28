using System.Diagnostics;

namespace CLI_Multi_Tool.Repository;

public class LockInRepo
{
    public void SaveTask()
    {
        Stopwatch stopwatch  = Stopwatch.StartNew();
        stopwatch.Start();
        
        Console.WriteLine("Temporizador iniciado. Presiona cualquier tecla para detener...");
        Console.ReadKey();
        
        stopwatch.Stop();
        
        TimeSpan tiempo = stopwatch.Elapsed;
        
        Console.WriteLine($"\nTiempo transcurrido: {tiempo.TotalSeconds:F2} segundos");
        Console.WriteLine($"Formato detallado: {tiempo.Hours:D2}:{tiempo.Minutes:D2}:{tiempo.Seconds:D2}.{tiempo.Milliseconds:D3}");
    }
}