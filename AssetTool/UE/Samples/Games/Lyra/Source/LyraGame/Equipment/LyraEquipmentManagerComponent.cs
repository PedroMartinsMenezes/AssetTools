namespace AssetTool
{
    [JsonAsset("LyraEquipmentManagerComponent")]
    public class ULyraEquipmentManagerComponent : UPawnComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}