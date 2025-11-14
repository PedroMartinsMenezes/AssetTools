namespace AssetTool
{
    [JsonAsset("LyraTestControllerBootTest")]
    public class ULyraTestControllerBootTest : UGauntletTestControllerBootTest
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}