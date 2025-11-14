namespace AssetTool
{
    [JsonAsset("InheritableComponentHandler")]
    public class UInheritableComponentHandler : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}