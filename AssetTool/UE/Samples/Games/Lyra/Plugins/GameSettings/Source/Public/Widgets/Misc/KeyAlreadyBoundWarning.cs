namespace AssetTool
{
    [JsonAsset("KeyAlreadyBoundWarning")]
    public class UKeyAlreadyBoundWarning : UGameSettingPressAnyKey
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}