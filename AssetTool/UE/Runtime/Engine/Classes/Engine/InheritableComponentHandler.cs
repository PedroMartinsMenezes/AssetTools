namespace AssetTool
{
    [JsonAsset("InheritableComponentHandler")]
    public class UInheritableComponentHandler : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}