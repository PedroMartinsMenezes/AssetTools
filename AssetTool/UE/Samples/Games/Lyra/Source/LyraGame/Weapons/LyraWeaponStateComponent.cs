namespace AssetTool
{
    [JsonAsset("LyraWeaponStateComponent")]
    public class ULyraWeaponStateComponent : UControllerComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}