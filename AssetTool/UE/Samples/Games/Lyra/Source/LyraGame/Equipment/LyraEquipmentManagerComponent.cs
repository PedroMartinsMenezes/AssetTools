namespace AssetTool
{
    [JsonAsset("LyraEquipmentManagerComponent")]
    public class ULyraEquipmentManagerComponent : UPawnComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}