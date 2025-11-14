namespace AssetTool
{
    [JsonAsset("LyraRangedWeaponInstance")]
    public class ULyraRangedWeaponInstance : ULyraWeaponInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}