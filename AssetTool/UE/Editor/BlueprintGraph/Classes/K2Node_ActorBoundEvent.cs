namespace AssetTool
{
    [JsonAsset("K2Node_ActorBoundEvent")]
    public class UK2Node_ActorBoundEvent : UK2Node_Event
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}