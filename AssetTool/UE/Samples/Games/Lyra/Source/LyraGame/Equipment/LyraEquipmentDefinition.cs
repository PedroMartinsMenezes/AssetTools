namespace AssetTool
{
    [JsonAsset("LyraEquipmentDefinition")]
    public class ULyraEquipmentDefinition : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}