namespace AssetTool
{
    [JsonAsset("LyraWeaponStateComponent")]
    public class ULyraWeaponStateComponent : UControllerComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}