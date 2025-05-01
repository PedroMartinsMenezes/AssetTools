namespace AssetTool
{
    [JsonAsset("MaterialInstanceDynamic")]
    public class UMaterialInstanceDynamic : UMaterialInstance
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}