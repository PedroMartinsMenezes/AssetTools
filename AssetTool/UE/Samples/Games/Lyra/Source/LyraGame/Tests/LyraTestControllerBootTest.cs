namespace AssetTool
{
    [JsonAsset("LyraTestControllerBootTest")]
    public class ULyraTestControllerBootTest : UGauntletTestControllerBootTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}