namespace AssetTool
{
    [JsonAsset("LyraJoystickWidget")]
    public class ULyraJoystickWidget : ULyraSimulatedInputWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}