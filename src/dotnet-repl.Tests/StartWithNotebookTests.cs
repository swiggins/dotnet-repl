using System.CommandLine.IO;
using System.CommandLine.Parsing;
using System.IO;
using System.Threading.Tasks;
using dotnet_repl.Tests.Utility;
using FluentAssertions;
using Spectre.Console;
using Xunit;

namespace dotnet_repl.Tests
{
    public class StartWithNotebookTests
    {
        [Fact]
        public async Task when_an_ipynb_is_specified_it_runs_it()
        {
            var directory = Path.GetDirectoryName(PathUtility.PathToCurrentSourceFile());

            using var writer = new StringWriter();

            var ansiConsole = new AnsiConsoleFactory().Create(new AnsiConsoleSettings
            {
                Ansi = AnsiSupport.Yes,
                Interactive = InteractionSupport.Yes,
                Out = new AnsiConsoleOutput(writer)
            });

            var parser = CommandLineParser.Create(ansiConsole);

            var console = new TestConsole();
            var result = await parser.InvokeAsync($"--notebook \"{directory}/test.ipynb\" --exit-after-run", console);

            console.Error.ToString().Should().BeEmpty();
            result.Should().Be(0);
            writer.ToString().Should().Contain("Hello from C#");
            writer.ToString().Should().Contain("Hello from F#");
            
            // TODO-JOSEQU (when_an_ipynb_is_specified_it_runs_it) write test
            Assert.True(false, "Test when_an_ipynb_is_specified_it_runs_it is not written yet.");
        }

        [Fact]
        public void When_an_ipynb_is_run_and_no_error_is_produced_then_the_exit_code_is_0()
        {
            

            // TODO-JOSEQU (When_an_ipynb_is_run_and_an_error_is_produced_from_a_cell_then_the_exit_code_is_1) write test
            Assert.True(false, "Test When_an_ipynb_is_run_and_an_error_is_produced_from_a_cell_then_the_exit_code_is_1 is not written yet.");
        }
        
        [Fact]
        public void When_an_ipynb_is_run_and_an_error_is_produced_from_a_cell_then_the_exit_code_is_1()
        {
            

            // TODO-JOSEQU (When_an_ipynb_is_run_and_an_error_is_produced_from_a_cell_then_the_exit_code_is_1) write test
            Assert.True(false, "Test When_an_ipynb_is_run_and_an_error_is_produced_from_a_cell_then_the_exit_code_is_1 is not written yet.");
        }
    }
}