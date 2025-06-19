namespace AssetTool
{
    [JsonAsset("MaterialInstanceDynamic")]
    public class UMaterialInstanceDynamic : UMaterialInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}