namespace AssetTool
{
    [JsonAsset("NiagaraSystemEditorFolder")]
    public class UNiagaraSystemEditorFolder : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraSystemEditorData")]
    public class UNiagaraSystemEditorData : UNiagaraEditorDataBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}