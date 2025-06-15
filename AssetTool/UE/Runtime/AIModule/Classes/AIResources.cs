namespace AssetTool
{
    [JsonAsset("AIResource_Movement")]
    public class UAIResource_Movement : UGameplayTaskResource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AIResource_Logic")]
    public class UAIResource_Logic : UGameplayTaskResource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}