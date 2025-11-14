namespace AssetTool
{
    [JsonAsset("ColorCorrectionWindow")]
    public class AColorCorrectionWindow : AColorCorrectRegion
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ColorCorrectWindow")]
    public class ADEPRECATED_ColorCorrectWindow : AColorCorrectionWindow
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}