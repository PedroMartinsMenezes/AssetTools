namespace AssetTool
{
    [JsonAsset("LyraEquipmentInstance")]
    public class ULyraEquipmentInstance : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}