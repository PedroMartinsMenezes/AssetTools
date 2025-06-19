namespace AssetTool
{
    [JsonAsset("K2Node_EvaluateLiveLinkFrameWithSpecificRole")]
    public class UK2Node_EvaluateLiveLinkFrameWithSpecificRole : UK2Node_EvaluateLiveLinkFrame
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("K2Node_EvaluateLiveLinkFrameAtWorldTime")]
    public class UK2Node_EvaluateLiveLinkFrameAtWorldTime : UK2Node_EvaluateLiveLinkFrame
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("K2Node_EvaluateLiveLinkFrameAtSceneTime")]
    public class UK2Node_EvaluateLiveLinkFrameAtSceneTime : UK2Node_EvaluateLiveLinkFrame
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}