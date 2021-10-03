<h1>Practice project to learn .NET 5 (work in progress)</h1>
<p>This project implements a simple store for music albums</p>
<p>A new version of this project is beeing built using CQRS server API and client MVC app</p>
<p>
Features:
    <ul>
        <li>
            Authentication and authorization
            <ul>
                <li>Local register and login</li>
                <li>Login using external services</li>
                <li>Email verification</li>
                <li>Forgot password</li>
            </ul>
        </li>
        <li>
            Store area
            <ul>
                <li>View (filter, order, search) albums</li>
                <li>Persist shopping cart using cookie Guid for not logged in users</li>
                <li>Checkout (without payment)</li>
                <li>View orders</li>
                <li>Manage account information</li>
            </ul>
        </li>
        <li>
            Administration area
            <ul>
                <li>View (filter, order, search), Add, edit, delete albums, genres, artists, orders</li>
                <li>Upload cover art</li>
            </ul>
        </li>
    </ul>
</p>
Using:
    <ul>
        <li>.Net core 5, Entity framework</li>
        <li>Oauth 2 for external logins</li>
        <li>Repository and Unit of work patterns</li>
    </ul>
</p>
TODOs:
    <ul>
        <li>Order state and cancellation</li>
        <li>Claim based authorization and Super admin role to manage admins</li>
        <li>Database auditing</li>
    </ul>
</p>
