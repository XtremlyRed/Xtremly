using System.Threading.Tasks;
using System.Windows.Input;

namespace Xtremly.Core
{
    public interface ICommand<TParameter> : ICommand
    {
        bool CanExecute(TParameter parameter);
        void Execute(TParameter parameter);
    }

    public interface ICommandAsync : ICommand
    {
        bool CanExecute();
        Task ExecuteAsync();
    }

    public interface ICommandAsync<TParameter> : ICommand
    {
        bool CanExecute(TParameter parameter);
        Task ExecuteAsync(TParameter parameter);
    }
}