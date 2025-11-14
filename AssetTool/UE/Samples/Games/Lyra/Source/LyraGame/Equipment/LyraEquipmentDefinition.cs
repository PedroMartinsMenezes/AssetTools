namespace AssetTool
{
    [JsonAsset("LyraEquipmentDefinition")]
    public class ULyraEquipmentDefinition : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}