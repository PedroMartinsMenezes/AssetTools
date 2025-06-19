namespace AssetTool
{
    [JsonAsset("BTTask_PushPawnAction")]
    public class UBTTask_PushPawnAction : UBTTask_PawnActionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}