namespace AssetTool
{
    [JsonAsset("LyraEquipmentInstance")]
    public class ULyraEquipmentInstance : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}