namespace AssetTool
{
    [JsonAsset("BaseCommandNativeUI")]
    public class UBaseCommandNativeUI : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UTBCommandUMGUI")]
    public class UUTBCommandUMGUI : UUserWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}