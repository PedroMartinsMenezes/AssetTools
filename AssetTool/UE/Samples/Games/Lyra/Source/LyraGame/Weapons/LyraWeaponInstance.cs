namespace AssetTool
{
    [JsonAsset("LyraWeaponInstance")]
    public class ULyraWeaponInstance : ULyraEquipmentInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}