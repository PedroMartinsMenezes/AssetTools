namespace AssetTool
{
    [JsonAsset("MaterialInstanceDynamic")]
    public class UMaterialInstanceDynamic : UMaterialInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}