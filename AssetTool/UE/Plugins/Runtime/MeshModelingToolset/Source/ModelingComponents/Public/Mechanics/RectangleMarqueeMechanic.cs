namespace AssetTool
{
    [JsonAsset("RectangleMarqueeMechanic")]
    public class URectangleMarqueeMechanic : UInteractionMechanic
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RectangleMarqueeInteraction")]
    public class URectangleMarqueeInteraction : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}