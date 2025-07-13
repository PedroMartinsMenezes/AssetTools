namespace AssetTool
{
    [JsonAsset("ColorCorrectionWindow")]
    public class AColorCorrectionWindow : AColorCorrectRegion
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DEPRECATED_ColorCorrectWindow")]
    public class ADEPRECATED_ColorCorrectWindow : AColorCorrectionWindow
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}