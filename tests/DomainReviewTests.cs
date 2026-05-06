using AtlasSimQueueFlow;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(76, 48, 30, 53);
        if (DomainReviewLens.Score(item) != 163) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
