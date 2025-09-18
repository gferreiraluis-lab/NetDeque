using System;
using NetDeque;
using Xunit;
using FluentAssertions;

namespace NetDeque.Tests
{
    public class DequeTests
    {
        [Fact]
        public void NovoDeque_DeveComecarVazio()
        {
            var dq = new Deque<int>();
            // Assert.Equal(0, dq.Count);
            dq.Count.Should().Be(0);
            // Assert.True(dq.IsEmpty);
            dq.IsEmpty.Should().BeTrue();
        }

        [Fact]
        public void AddNoInicio_DeveInserirNoComeco()
        {
            var dq = new Deque<int>();
            dq.AddBeg(10);

            // Assert.False(dq.IsEmpty);
            dq.IsEmpty.Should().BeFalse();
            // Assert.Equal(1, dq.Count);
            dq.Count.Should().Be(1);
            // Assert.Equal(10, dq.PeekBeg());
            dq.PeekBeg().Should().Be(10);
            // Assert.Equal(10, dq.PeekEnd());
            dq.PeekEnd().Should().Be(10);
        }

        [Fact]
        public void AddNoInicio_VariosElementos_DeveRetornarNaOrdemInversa()
        {
            var dq = new Deque<int>();
            dq.AddBeg(1);
            dq.AddBeg(2);
            dq.AddBeg(3);

            // Assert.Equal(3, dq.RemBeg());
            dq.RemBeg().Should().Be(3);
            // Assert.Equal(2, dq.RemBeg());
            dq.RemBeg().Should().Be(2);
            // Assert.Equal(1, dq.RemBeg());
            dq.RemBeg().Should().Be(1);
            // Assert.True(dq.IsEmpty);
            dq.IsEmpty.Should().BeTrue();
        }

        [Fact]
        public void AddNoFinal_DeveInserirNoFim()
        {
            var dq = new Deque<int>();
            dq.AddEnd(10);

            // Assert.False(dq.IsEmpty);
            dq.IsEmpty.Should().BeFalse();
            // Assert.Equal(1, dq.Count);
            dq.Count.Should().Be(1);
            // Assert.Equal(10, dq.PeekBeg());
            dq.PeekBeg().Should().Be(10);
            // Assert.Equal(10, dq.PeekEnd());
            dq.PeekEnd().Should().Be(10);
        }

        [Fact]
        public void AddNoFinal_VariosElementos_DeveRetornarNaMesmaOrdem()
        {
            var dq = new Deque<int>();
            dq.AddEnd(1);
            dq.AddEnd(2);
            dq.AddEnd(3);

            // Assert.Equal(3, dq.RemEnd());
            dq.RemEnd().Should().Be(3);
            // Assert.Equal(2, dq.RemEnd());
            dq.RemEnd().Should().Be(2);
            // Assert.Equal(1, dq.RemEnd());
            dq.RemEnd().Should().Be(1);
            // Assert.True(dq.IsEmpty);
            dq.IsEmpty.Should().BeTrue();
        }

        [Fact]
        public void RemoverDoInicio_Vazio_DeveLancarExcecao()
        {
            var dq = new Deque<int>();
            // Assert.Throws<InvalidOperationException>(() => dq.RemBeg());
            Action act = () => dq.RemBeg();
            act.Should().Throw<InvalidOperationException>();
        }

        [Fact]
        public void RemoverDoInicio_DeveReduzirCountECorresponderOrdem()
        {
            var dq = new Deque<int>();
            dq.AddBeg(1);
            dq.AddBeg(2);
            dq.AddBeg(3);

            // Assert.Equal(3, dq.RemBeg());
            dq.RemBeg().Should().Be(3);
            // Assert.Equal(2, dq.RemBeg());
            dq.RemBeg().Should().Be(2);
            // Assert.Equal(1, dq.RemBeg());
            dq.RemBeg().Should().Be(1);
            // Assert.True(dq.IsEmpty);
            dq.IsEmpty.Should().BeTrue();
        }

        [Fact]
        public void RemoverDoFinal_Vazio_DeveLancarExcecao()
        {
            var dq = new Deque<int>();
            // Assert.Throws<InvalidOperationException>(() => dq.RemEnd());
            Action act = () => dq.RemEnd();
            act.Should().Throw<InvalidOperationException>();
        }

        [Fact]
        public void RemoverDoFinal_DeveReduzirCountECorresponderOrdem()
        {
            var dq = new Deque<int>();
            dq.AddEnd(1);
            dq.AddEnd(2);
            dq.AddEnd(3);

            // Assert.Equal(3, dq.RemEnd());
            dq.RemEnd().Should().Be(3);
            // Assert.Equal(2, dq.RemEnd());
            dq.RemEnd().Should().Be(2);
            // Assert.Equal(1, dq.RemEnd());
            dq.RemEnd().Should().Be(1);
            // Assert.True(dq.IsEmpty);
            dq.IsEmpty.Should().BeTrue();
        }



    }
}
