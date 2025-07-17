namespace AssetTool
{
    [JsonAsset("KeyAlreadyBoundWarning")]
    public class UKeyAlreadyBoundWarning : UGameSettingPressAnyKey
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}