namespace AssetTool
{
    [JsonAsset("LyraJoystickWidget")]
    public class ULyraJoystickWidget : ULyraSimulatedInputWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}