namespace AssetTool
{
    [JsonAsset("InheritableComponentHandler")]
    public class UInheritableComponentHandler : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}