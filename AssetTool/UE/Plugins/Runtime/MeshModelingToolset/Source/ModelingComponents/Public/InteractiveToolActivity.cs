namespace AssetTool
{
    [JsonAsset("InteractiveToolActivity")]
    public class UInteractiveToolActivity : UInteractionMechanic
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}