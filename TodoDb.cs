// データベースコンテキストを定義

// 名前空間の指定を省略
// この場合，Microsoft.EntityFrameworkCoreの要素を直接指定可能にする
using Microsoft.EntityFrameworkCore;

// TodoDbクラスを定義
// DbContextクラスを継承
class TodoDb : DbContext
{
  // "public TodoDb(... )"でこのクラス(TodoDb)のコンストラクタを定義
  // "DbContextOptions<TodoDb> options"でDbContextOptions<TodoDb>型の引数を受け取り，options変数に格納
  // ": base(options)"で基底クラス(DbContext)のコンストラクタにoptions変数を渡す

  // DbContextOptions<TodoDb> は、ジェネリック型 DbContextOptions<TContext> の具体的な型引数として TodoDb を指定したもの
  // ジェネリック型: https://ufcpp.net/study/csharp/sp2_generics.html
  public TodoDb(DbContextOptions<TodoDb> options) : base(options)
  {
  }

  public DbSet<Todo> Todos => Set<Todo>();
}
