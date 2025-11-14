namespace AssetTool
{
    [JsonAsset("NiagaraSequencerTrackFilter")]
    public class UNiagaraSequencerTrackFilter : USequencerTrackFilterExtension
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}