namespace AssetTool
{
    [JsonAsset("LyraCameraMode_ThirdPerson")]
    public class ULyraCameraMode_ThirdPerson : ULyraCameraMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}