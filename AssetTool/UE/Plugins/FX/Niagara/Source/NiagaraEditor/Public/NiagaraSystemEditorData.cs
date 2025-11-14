namespace AssetTool
{
    [JsonAsset("NiagaraSystemEditorFolder")]
    public class UNiagaraSystemEditorFolder : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraSystemEditorData")]
    public class UNiagaraSystemEditorData : UNiagaraEditorDataBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}