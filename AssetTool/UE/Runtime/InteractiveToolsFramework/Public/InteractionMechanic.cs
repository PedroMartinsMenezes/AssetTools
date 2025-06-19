namespace AssetTool
{
    [JsonAsset("InteractionMechanic")]
    public class UInteractionMechanic : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}