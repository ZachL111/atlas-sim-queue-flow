using AtlasSimQueueFlow;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(72, 86, 21, 10, 6);
        if (Policy.Score(signalcase_1) != 147) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(68, 85, 21, 6, 12);
        if (Policy.Score(signalcase_2) != 188) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "accept") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(87, 82, 21, 11, 11);
        if (Policy.Score(signalcase_3) != 193) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "accept") throw new Exception("decision mismatch");
    }
}
