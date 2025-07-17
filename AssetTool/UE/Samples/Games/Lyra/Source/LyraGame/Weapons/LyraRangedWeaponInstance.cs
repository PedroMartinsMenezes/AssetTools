namespace AssetTool
{
    [JsonAsset("LyraRangedWeaponInstance")]
    public class ULyraRangedWeaponInstance : ULyraWeaponInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}