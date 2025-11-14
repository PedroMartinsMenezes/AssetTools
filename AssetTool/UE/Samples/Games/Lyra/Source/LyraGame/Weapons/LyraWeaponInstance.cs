namespace AssetTool
{
    [JsonAsset("LyraWeaponInstance")]
    public class ULyraWeaponInstance : ULyraEquipmentInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}